using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace OOP
{
    class Model : Vehicle
    {
        public Guid ID { get; set; }
        public string _ModelName { get; set; }
        public  int Weight { get; set; }
        public DateTime _DateOfMan { get; set; }
        public Guid Id_vehicle { get; set; }


        //public override void Save()
        //{
        //    VehicleContext context = new VehicleContext();
        //    context.Models.Add(new Model { ID = Guid.NewGuid(), _ModelName = this._ModelName, _DateOfMan = this._DateOfMan, Id_vehicle = base.Id });
        //    context.SaveChanges();
        //}
    }
}
