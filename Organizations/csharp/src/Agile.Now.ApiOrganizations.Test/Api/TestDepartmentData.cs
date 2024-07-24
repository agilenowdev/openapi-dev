using Agile.Now.ApiOrganizations.Model;
using System;
using System.Linq;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal class TestDepartmentData
{
    public static DepartmentInsertData CreateDepartmentData(string suffix = null)
    {
        var name = "unit-test-department" + suffix;
        var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
        return new
        (
            name: uniqueName,
            departmentTypeId: EnumDepartmentType.Internal,
            parentDepartmentId: new("Id", null),
            contactName: name,
            contactEmail: name + "@agilenow.io"
        )
        {
            CountryId = EnumCountry.FIN
        };
    }

    public static DepartmentInsertData[] CreateDepartmentDataList(int count) =>
        Enumerable.Range(0, count).Select(i => CreateDepartmentData(i.ToString())).ToArray();
}
