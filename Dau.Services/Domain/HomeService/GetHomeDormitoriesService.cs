﻿using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dau.Services.Domain.HomeService
{
   public class GetHomeDormitoriesService : IGetHomeDormitoriesService
    {
        private readonly IStringLocalizer Localizer;

        public GetHomeDormitoriesService(IStringLocalizer _Localizer)
        {
            Localizer = _Localizer;
        }

    

        public HomePageModel GetPopularDormitories(DormitoryPartialModel Model)
        {
            HomePageModel model= new HomePageModel();

            model.DormitoryPartialModel = Model;
            model.DormitoryCardsList = new List<DormitoryCard>
            {
               

                  new DormitoryCard
                {
                    DormitoryName = "Alfam dormitory",
                     DormitorySeoFriendlyUrl = "Alfam-dormitory",
                    DormitoryId ="2134",
                    ImageUrl="https://dormitories.emu.edu.tr/PublishingImages/Stock/yurtlar-mudurlugu.jpg?RenditionID=6",
                    RatingText =Localizer["Excellent"],
                    RatingNo =9.6,
                    ReviewsNo = 14
                },

                  new DormitoryCard
                {
                    DormitoryName = "Akdeniz dormitory",
                     DormitorySeoFriendlyUrl = "Akdeniz-dormitory",
                    DormitoryId ="5434",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/Single%20suit%202.jpg?RenditionID=6",
                    RatingText =Localizer["Excellent"],
                    RatingNo =6.7,
                    ReviewsNo = 22
                }, new DormitoryCard
                {
                    DormitoryName = "Hasan Uzuk",
                    DormitorySeoFriendlyUrl = "Hasan-Uzuk",
                    DormitoryId ="2334",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/kamacioglu/S%C3%9C%C4%B0T_1.jpg?RenditionID=6",
                    RatingText =Localizer["Very Good"],
                    RatingNo =9.6,
                    ReviewsNo = 15
                },

                 new DormitoryCard
                {
                    DormitoryName = "Sanel",
                     DormitorySeoFriendlyUrl = "Sanel",
                    DormitoryId ="2244",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/Double%20suit%2011.jpg?RenditionID=6",
                    RatingText =Localizer["Fantastic"],
                    RatingNo =2.6,
                    ReviewsNo = 12
                },
                    new DormitoryCard
                {
                    DormitoryName = "Pop art dormitory",
                     DormitorySeoFriendlyUrl = "Pop-art-dormitory",
                    DormitoryId ="542134",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/Single%20suit%203.jpg?RenditionID=6",
                    RatingText =Localizer["Very Good"],
                    RatingNo =5.9,
                    ReviewsNo = 11
                },

                 new DormitoryCard
                {
                    DormitoryName = "Novel dormitory",
                     DormitorySeoFriendlyUrl = "Novel-dormitory",
                    DormitoryId ="213324",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/_DSC8319.jpg?RenditionID=6",
                    RatingText =Localizer["Good"],
                    RatingNo =8.2,
                    ReviewsNo = 14
                },



            };
            return model;
           
        }

        public HomePageModel GetHighlyRatedDormitories(DormitoryPartialModel Model)
        {
            HomePageModel model = new HomePageModel();

            model.DormitoryPartialModel = Model;
            model.DormitoryCardsList = new List<DormitoryCard>
            {
                new DormitoryCard
                {
                    DormitoryName = "Hasan Uzuk",
                    DormitorySeoFriendlyUrl = "Hasan-Uzuk",
                    DormitoryId ="2334",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/kamacioglu/S%C3%9C%C4%B0T_1.jpg?RenditionID=6",
                    RatingText =Localizer["Very Good"],
                    RatingNo =9.6,
                    ReviewsNo = 15
                },

                 new DormitoryCard
                {
                    DormitoryName = "Sanel",
                     DormitorySeoFriendlyUrl = "Sanel",
                    DormitoryId ="2244",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/Double%20suit%2011.jpg?RenditionID=6",
                    RatingText =Localizer["Fantastic"],
                    RatingNo =2.6,
                    ReviewsNo = 12
                },

                  new DormitoryCard
                {
                    DormitoryName = "Alfam dormitory",
                     DormitorySeoFriendlyUrl = "Alfam-dormitory",
                    DormitoryId ="2134",
                    ImageUrl="https://dormitories.emu.edu.tr/PublishingImages/Stock/yurtlar-mudurlugu.jpg?RenditionID=6",
                    RatingText =Localizer["Excellent"],
                    RatingNo =9.6,
                    ReviewsNo = 14
                },

                  new DormitoryCard
                {
                    DormitoryName = "Akdeniz dormitory",
                     DormitorySeoFriendlyUrl = "Akdeniz-dormitory",
                    DormitoryId ="5434",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/Single%20suit%202.jpg?RenditionID=6",
                    RatingText =Localizer["Excellent"],
                    RatingNo =6.7,
                    ReviewsNo = 22
                },
                    new DormitoryCard
                {
                    DormitoryName = "Pop art dormitory",
                     DormitorySeoFriendlyUrl = "Pop-art-dormitory",
                    DormitoryId ="542134",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/Single%20suit%203.jpg?RenditionID=6",
                    RatingText =Localizer["Very Good"],
                    RatingNo =5.9,
                    ReviewsNo = 11
                },

                 new DormitoryCard
                {
                    DormitoryName = "Novel dormitory",
                     DormitorySeoFriendlyUrl = "Novel-dormitory",
                    DormitoryId ="213324",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/_DSC8319.jpg?RenditionID=6",
                    RatingText =Localizer["Good"],
                    RatingNo =8.2,
                    ReviewsNo = 14
                },



            };
            return model;

        }


        public HomePageModel GetCoolOffersDeals(DormitoryPartialModel Model)
        {
            HomePageModel model = new HomePageModel();

            model.DormitoryPartialModel = Model;
            model.DormitoryCardsList = new List<DormitoryCard>
            {
               
                  new DormitoryCard
                {
                    DormitoryName = "Akdeniz dormitory",
                     DormitorySeoFriendlyUrl = "Akdeniz-dormitory",
                    DormitoryId ="5434",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/Single%20suit%202.jpg?RenditionID=6",
                    RatingText =Localizer["Excellent"],
                    RatingNo =6.7,
                    ReviewsNo = 22
                },
                    new DormitoryCard
                {
                    DormitoryName = "Pop art dormitory",
                     DormitorySeoFriendlyUrl = "Pop-art-dormitory",
                    DormitoryId ="542134",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/Single%20suit%203.jpg?RenditionID=6",
                    RatingText =Localizer["Very Good"],
                    RatingNo =5.9,
                    ReviewsNo = 11
                },
                     new DormitoryCard
                {
                    DormitoryName = "Hasan Uzuk",
                    DormitorySeoFriendlyUrl = "Hasan-Uzuk",
                    DormitoryId ="2334",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/kamacioglu/S%C3%9C%C4%B0T_1.jpg?RenditionID=6",
                    RatingText =Localizer["Very Good"],
                    RatingNo =9.6,
                    ReviewsNo = 15
                },

                 new DormitoryCard
                {
                    DormitoryName = "Sanel",
                     DormitorySeoFriendlyUrl = "Sanel",
                    DormitoryId ="2244",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/Double%20suit%2011.jpg?RenditionID=6",
                    RatingText =Localizer["Fantastic"],
                    RatingNo =2.6,
                    ReviewsNo = 12
                },

                  new DormitoryCard
                {
                    DormitoryName = "Alfam dormitory",
                     DormitorySeoFriendlyUrl = "Alfam-dormitory",
                    DormitoryId ="2134",
                    ImageUrl="https://dormitories.emu.edu.tr/PublishingImages/Stock/yurtlar-mudurlugu.jpg?RenditionID=6",
                    RatingText =Localizer["Excellent"],
                    RatingNo =9.6,
                    ReviewsNo = 14
                },

                 new DormitoryCard
                {
                    DormitoryName = "Novel dormitory",
                     DormitorySeoFriendlyUrl = "Novel-dormitory",
                    DormitoryId ="213324",
                    ImageUrl="https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/novel/_DSC8319.jpg?RenditionID=6",
                    RatingText =Localizer["Good"],
                    RatingNo =8.2,
                    ReviewsNo = 14
                },



            };
            return model;

        }


    }

    public class DormitoryPartialModel
    {
        public string SectionId { get; set; }
        public string SwiperId { get; set; }
    }

    public class DormitoryCard
    {
        public string DormitoryId { get; set; }
        public string DormitorySeoFriendlyUrl { get; set; }
        public string ImageUrl { get; set; }
        public string DormitoryName { get; set; }
        public string RatingText { get; set; }
        public double RatingNo { get; set; }
        public int ReviewsNo { get; set; }
    }

    public class HomePageModel
    {

        public DormitoryPartialModel DormitoryPartialModel { get; set; }
        public List<DormitoryCard> DormitoryCardsList { get; set; }
    }
}