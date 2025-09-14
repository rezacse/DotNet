using InterviewCoding.BetterCoding.Builders.Machine;
using InterviewCoding.BetterCoding.Builders.Person;
using InterviewCoding.BetterCoding.Interfaces;
using InterviewCoding.BetterCoding.Models;

namespace InterviewCoding.BetterCoding
{
    public static class UserFactories
    {
        public static Func<IUser> PersonFactory =>
            PersonBuilder
                .Person()
                .WithFirstName("Max")
                .WithLastName("Planck")
                .WithPrimaryContact(new EmailAddress("max.planck@my-institute.com"))
                .WithSecondaryContact(new EmailAddress("max@home-of-plancks.com"))
                .AndNoMoreContacts()
                .Build;

        public static Func<IUser> MachineFactory => CreateMachineFactory(CreateLegalEntity);

        private static Func<IUser> CreateMachineFactory(Func<LegalEntity> ownerFactory) =>
            MachineBuilder
                .Machine()
                .WithProducer(new Producer())
                .WithModel("fast-one")
                .OwnedBy(ownerFactory())
                .Build;

        private static Func<LegalEntity> CreateLegalEntity =>
            CreateLegalEntityFactory(() => new EmailAddress("big@co"));
        private static Func<LegalEntity> CreateLegalEntityFactory(
            Func<EmailAddress> emailAddressFactory) =>
                () => new LegalEntity("Big Co.", emailAddressFactory(),
                                      new PhoneNumber(123, 45, 6789));

    }
}
