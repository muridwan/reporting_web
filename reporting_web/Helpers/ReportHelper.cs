using System;
using System.Collections.Generic;
using reporting_web.Models;

namespace reporting_web.Helpers
{
    public static class ReportHelper
    {
        public static readonly Dictionary<string, ReportDefinition> Reports =
            new Dictionary<string, ReportDefinition>()
        {
            {
                "PERSENKLAIMCBG",
                new ReportDefinition
                {
                    StoredProcedure = "spGetPersenKlaimCbg",
                    ModelType = typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMUY",
                new ReportDefinition
                {
                    StoredProcedure = "spGetPersenKlaimUY",
                    ModelType = typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMCOL",
                new ReportDefinition
                {
                    StoredProcedure = "spGetPersenKlaimCOL",
                    ModelType = typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMUSIADIE",
                new ReportDefinition
                {
                    StoredProcedure="spGetPersenJumKlaimUsiaDie",
                    ModelType=typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMWAKTUDIE",
                new ReportDefinition
                {
                    StoredProcedure="spGetPersenJumKlaimWaktuDie",
                    ModelType=typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMUSIAWAKTUDIE",
                new ReportDefinition
                {
                    StoredProcedure="spGetPersenJumKlaimWaktuUsiaDie",
                    ModelType=typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMDESCLOSSDIE",
                new ReportDefinition
                {
                    StoredProcedure="spGetPersenKlaimDescLossDie",
                    ModelType=typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMUSIAPHK",
                new ReportDefinition
                {
                    StoredProcedure="spGetPersenJumKlaimUsiaPHK",
                    ModelType=typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMUSIAKRM",
                new ReportDefinition
                {
                    StoredProcedure="spGetPersenJumKlaimUsiaKrm",
                    ModelType=typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMCOB",
                new ReportDefinition
                {
                    StoredProcedure="spGetPersenKlaimCob",
                    ModelType=typeof(DataSettleKlaim)
                }
            },

            {
                "PERSENKLAIMSUBRO",
                new ReportDefinition
                {
                    StoredProcedure="spGetPersenSubroCbg",
                    ModelType=typeof(DataSettleKlaim)
                }
            },

            {
                "LAPORANKLAIMSUMBIS",
                new ReportDefinition
                {
                    StoredProcedure="spLaporanKlaimSumbis",
                    ModelType=typeof(DataKlaimSumbis)
                }
            }
        };
    }
}