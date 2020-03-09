using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Model.ViewModels;
using GraduationApi_v1._0.Repo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Services
{
    public class SponsorService
    {
        private readonly MainOperation<Sponsor> SponsorMainOperation;
        private readonly FileUploadService fileUploadService;
        public SponsorService(MainOperation<Sponsor> SponsorMainOperation, FileUploadService fileUploadService)
        {
            this.SponsorMainOperation = SponsorMainOperation;
            this.fileUploadService = fileUploadService;
        }
        public Sponsor SponsorAdded(SponsorVM sponsorVM)
        {

            Sponsor Sponsor = new Sponsor();
            if (sponsorVM.ImageName != null)
            {
                Sponsor.ImageName = fileUploadService.upload(sponsorVM.ImageName);
            }
            //else add a profile avatar image

            SponsorMainOperation.Insert(Sponsor);
            SponsorMainOperation.Save();


            return Sponsor;
        }
    }
}
