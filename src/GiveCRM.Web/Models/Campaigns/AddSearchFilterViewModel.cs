﻿namespace GiveCRM.Web.Models.Campaigns
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using GiveCRM.Models.Search;

    public class AddSearchFilterViewModel : ViewModelBase
    {
        public int CampaignId { get; set; }

        public string CriteriaName { get; set; }
        public SearchOperator SearchOperator { get; set; }
        public string Value { get; set; }

        public IEnumerable<SelectListItem> CriteriaNames { get; set; }
        public IEnumerable<SelectListItem> SearchOperators { get; set; }

        public AddSearchFilterViewModel() : this(string.Empty)
        {}

        public AddSearchFilterViewModel(string title) : base(title)
        {}
    }
}