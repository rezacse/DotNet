//// See https://aka.ms/new-console-template for more information
//using InterviewCoding.BetterCoding;
//using InterviewCoding.BetterCoding.Interfaces;
//using InterviewCoding.BetterCoding.Models;
//using InterviewCoding.BetterCoding.Specifications.ContactInfo;
//using InterviewCoding.BetterCoding.Specifications.LegalEntity;
//using InterviewCoding.BetterCoding.Specifications.Producer;
//using InterviewCoding.BetterCoding.Specifications.User;
//using InterviewCoding.BetterCoding.Validation;

//static void ConfigureUser()
//{
//    var manager = new PersonalManager(UserFactories.PersonFactory);
//    manager.Notify("Hello");

//    var person = new PersonalManager(UserFactories.MachineFactory);
//    person.Notify("Hello");

//    //var person = new PersonalBuilder(
//    //    PersonBuilder
//    //        .Person()
//    //        .WithFirstName("Max")
//    //        .WithLastName("Planck")
//    //        .WithPrimaryContact(new EmailAddress("max.planck@my-institute.com"))
//    //        .WithSecondaryContact(new EmailAddress("max@home-of-planck.com"))
//    //        .AndNoMoreContacts()
//    //        .Build);

//    //person.Notify("Hello");

//    Console.WriteLine();

//}

////ConfigureUser();

////------------------------------------------------
//static void DoTheJob(Person person, Specification<Person> validator)
//{
//    if (!validator.IsSatisfiedBy(person))
//    {
//        Console.WriteLine("Not valid.....");
//        return;
//    }

//    Console.WriteLine($"Name: {person.Name}");
//    Console.WriteLine($"Surname: {person.Surname}");

//    Console.WriteLine("Contacts");
//    foreach (IContactInfo contact in person.Contacts)
//        Console.WriteLine($"{(contact == person.PrimaryContact ? "*": " ")} {contact}");
//    Console.WriteLine(new string('-', 20));
//}

//var user = new Person
//{
//    Surname = "Max",
//    Name = "Planck",
//};

//DoTheJob(user
//    , Spec<Person>.NotNull(p => p.Name)
//        .And(Spec<Person>.NotNull(p => p.Surname))
//        .And(Spec<Person>.NotNull(p => p.Contacts))
//        .And(
//            Spec<Person>.NotNull(p => p.PrimaryContact)
//            .Or(Spec<Person>.IsTrue(p => p.Contacts.Contains(p.PrimaryContact))))
//    );

////------------------------------------------------
//IUser machine =
//                UserSpecification
//                    .ForMachine()
//                    .ProducedBy(
//                        ProducerSpecification
//                            .WithName("Big Co."))
//                    .WithModel("Shiny one")
//                    .OwnedBy(
//                        LegalEntitySpecification
//                            .Initialize()
//                            .WithCompanyName("Properties Co.")
//                            .WithEmailAddress(
//                                ContactSpecification.ForEmailAddress("one@prop"))
//                            .WithPhoneNumber(
//                                ContactSpecification
//                                    .ForPhoneNumber()
//                                    .WithCountryCode(1)
//                                    .WithAreaCode(23)
//                                    .WithNumber(456))
//                            .WithOtherContact(
//                                ContactSpecification.ForEmailAddress("two@prop"))
//                            .AndNoMoreContacts())
//                    .Build();

//Console.WriteLine(machine);


////------------------------------------------------
//IUser person =
//                UserSpecification
//                    .ForPerson()
//                    .WithName("Anas")
//                    .WithSurname("Al")
//                    .WithPrimaryContact(
//                        ContactSpecification.ForEmailAddress("anas@com"))
//                    .WithAlternateContact(
//                        ContactSpecification.ForEmailAddress("al@com"))
//                    .AndNoMoreContacts()
//                    .Build();

//Console.WriteLine(person);

//Console.WriteLine("Reached end of demonstration...");
//Console.ReadLine();
