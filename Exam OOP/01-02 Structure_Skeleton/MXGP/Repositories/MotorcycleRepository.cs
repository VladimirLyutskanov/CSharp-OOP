using MXGP.Models.Motorcycles;
using MXGP.Models.Motorcycles.Contracts;
using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    class MotorcycleRepository : IRepository<IMotorcycle>
    {
        private readonly List<IMotorcycle> motocycles;
        public MotorcycleRepository()
        {
            this.motocycles = new List<IMotorcycle>();
        }
        public IMotorcycle GetByName(string name) 
            => this.motocycles.FirstOrDefault(n => n.Model == name);
        public IReadOnlyCollection<IMotorcycle> GetAll() 
            => this.motocycles.ToList();
        public void Add(IMotorcycle model)
            => this.motocycles.Add(model);  

        public bool Remove(IMotorcycle model) 
            => this.motocycles.Remove(model);
    }
}
