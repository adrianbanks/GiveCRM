﻿using System;
using System.Text;
using GiveCRM.Models;
using NUnit.Framework;
using Simple.Data;

namespace GiveCRM.DataAccess.Test
{
    [TestFixture]
    public class CampaignsTest
    {
        private readonly dynamic db = Database.OpenNamedConnection("GiveCRM");

        [SetUp]
        public void SetUp()
        {
            db.Donations.DeleteAll();
            db.CampaignRuns.DeleteAll();
            db.Campaigns.DeleteAll();
            db.PhoneNumbers.DeleteAll();
            db.MemberFacetValues.DeleteAll();
            db.MemberFacets.DeleteAll();
            db.Members.DeleteAll();
        }

        [Test]
        public void InsertCampaign()
        {
            var campaigns = new Campaigns();
            var campaign = new Campaign
                               {
                                   Name = "Test",
                                   Description = "Test"
                               };
            campaign = campaigns.Insert(campaign);
            Assert.AreNotEqual(0, campaign.Id);
            Assert.AreEqual("N", campaign.IsClosed);
        }
    }
}
