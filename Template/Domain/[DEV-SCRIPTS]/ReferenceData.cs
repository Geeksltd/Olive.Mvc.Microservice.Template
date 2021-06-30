using Olive;
using Olive.Entities;
using Olive.Entities.Data;
using System.Threading.Tasks;

namespace Domain
{
    [EscapeGCop("Hardcode values are acceptable here")]
    public class ReferenceData : IReferenceData
    {
        static IDatabase Database => Context.Current.Database();
        
        async Task<T> Create<T>(T item) where T : IEntity
        {
            await Database.Save(item, SaveBehaviour.BypassAll);
            return item;
        }

        public async Task Create()
        {
            // ...
        }
    }
}
