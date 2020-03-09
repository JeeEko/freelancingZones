using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Model.ViewModels;
using GraduationApi_v1._0.Repo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Services
{
    public class ZoneServise
    {
        private readonly MainOperation<Zone> ZoneMainOperation;
        FileUploadService fileUploadService;
        public ZoneServise(MainOperation<Zone> ZoneMainOperation,  FileUploadService fileUploadService)
        {
            this.ZoneMainOperation = ZoneMainOperation;
            this.fileUploadService = fileUploadService;
        }
        public Zone ZoneEdited(ZoneVM Zonevm)
        {

            Zone Zone = ZoneMainOperation.GetById(Zonevm.ID);
            if(Zone!=null)
            {
                Zone.Name = Zonevm.Name;
                Zone.NumberOfRooms = Zonevm.NumberOfRooms;
                Zone.Place = Zonevm.Place;
                Zone.Available = Zonevm.Available;
                Zone.Capacity = Zonevm.Capacity;
                if (Zonevm.ImageUrl != null)
                {
                    Zone.ImageUrl = fileUploadService.upload(Zonevm.ImageUrl);
                }
                //else add a profile avatar image

                ZoneMainOperation.Update(Zone);
                ZoneMainOperation.Save();
            }
                
            return Zone;
        }
        public Zone ZoneAdded(ZoneVM Zonevm)
        {

            Zone Zone = new Zone();
            
            
                Zone.Name = Zonevm.Name;
                Zone.NumberOfRooms = Zonevm.NumberOfRooms;
                Zone.Place = Zonevm.Place;
                Zone.Available = Zonevm.Available;
                Zone.Capacity = Zonevm.Capacity;
                if (Zonevm.ImageUrl != null)
                {
                    Zone.ImageUrl = fileUploadService.upload(Zonevm.ImageUrl);
                }
                //else add a profile avatar image

                ZoneMainOperation.Insert(Zone);
                ZoneMainOperation.Save();
            

            return Zone;
        }
    }
}
