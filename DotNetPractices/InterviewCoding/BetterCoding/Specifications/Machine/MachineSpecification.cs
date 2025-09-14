using InterviewCoding.BetterCoding.Specifications;
using InterviewCoding.BetterCoding.Specifications.Machine.Interfaces;

namespace InterviewCoding.BetterCoding.Specifications.Machine
{
    public class MachineSpecification :
        IExpectProducer, IExpectModel, IExpectOwner,
        IBuildingSpecification<Models.Machine>
    {
        private IBuildingSpecification<Models.Producer> ProducerSpec { get; set; }
        private string Model { get; set; }
        private IBuildingSpecification<Models.LegalEntity> OwnerSpec { get; set; }

        private MachineSpecification() { }

        public static IExpectProducer Initialize() => new MachineSpecification();

        public IExpectModel ProducedBy(IBuildingSpecification<Models.Producer> producerSpec)
        {
            if (producerSpec == null)
                throw new ArgumentNullException();

            return new MachineSpecification()
            {
                ProducerSpec = producerSpec
            };
        }

        public IExpectOwner WithModel(string model)
        {
            if (string.IsNullOrEmpty(model))
                throw new ArgumentException();

            return new MachineSpecification()
            {
                ProducerSpec = ProducerSpec,
                Model = model
            };
        }

        public IBuildingSpecification<Models.Machine> OwnedBy(IBuildingSpecification<Models.LegalEntity> ownerSpec)
        {
            if (ownerSpec == null)
                throw new ArgumentNullException();

            return new MachineSpecification()
            {
                ProducerSpec = ProducerSpec,
                Model = Model,
                OwnerSpec = ownerSpec
            };
        }

        public Models.Machine Build() =>
            new Models.Machine()
            {
                Producer = ProducerSpec.Build(),
                Model = Model,
                Owner = OwnerSpec.Build()
            };

        public bool Equals(IBuildingSpecification<Models.Machine> other) =>
            Equals(other as MachineSpecification);

        private bool Equals(MachineSpecification other) =>
            other != null &&
            ProducerSpec.SafeEquals(other.ProducerSpec) &&
            Model == other.Model &&
            OwnerSpec.SafeEquals(other.OwnerSpec);
    }
}
