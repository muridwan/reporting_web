using reporting_web.Controllers;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace reporting_web.Helpers
{
    public static class ReportExecutor
    {
        public static object Execute(
            KlaimController controller,
            ReportDefinition report,
            string SDate,
            string EDate,
            string COB,
            string TOC,
            List<string> ListTOC,
            string token,
            int roleId)
        {
            MethodInfo method =
                typeof(KlaimController)
                .GetMethod("GetDataReport");

            MethodInfo generic =
                method.MakeGenericMethod(report.ModelType);

            return generic.Invoke(controller,
                new object[]
                {
                    SDate,
                    EDate,
                    report.StoredProcedure,
                    COB,
                    TOC,
                    ListTOC,
                    token,
                    roleId
                });
        }
    }
}