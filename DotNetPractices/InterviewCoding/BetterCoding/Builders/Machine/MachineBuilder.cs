using InterviewCoding.BetterCoding.Builders.Machine.Interfaces;
using InterviewCoding.BetterCoding.Models;

namespace InterviewCoding.BetterCoding.Builders.Machine
{
    public class MachineBuilder :
        IProducerHolder, IModelHolder, IOwned, IMachineBuilder
    {
        private Producer Producer { get; set; }
        private string Model { get; set; }
        private LegalEntity Owner { get; set; }

        private MachineBuilder() { }

        private MachineBuilder(MachineBuilder other)
        {
            Producer = other.Producer;
            Model = other.Model;
            Owner = other.Owner;
        }

        public static IProducerHolder Machine() => new MachineBuilder();

        public IModelHolder WithProducer(Producer producer) =>
            new MachineBuilder()
            {
                Producer = producer
            };

        public IOwned WithModel(string model) =>
            new MachineBuilder(this)
            {
                Model = model
            };

        public IMachineBuilder OwnedBy(LegalEntity company) =>
            new MachineBuilder(this)
            {
                Owner = company
            };

        public Models.Machine Build() =>
            new Models.Machine(Producer, Model, Owner);

    }
}
