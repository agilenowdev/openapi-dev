using System;
using System.Linq;
using Agile.Now.AccessHub.Model;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal static class TestDepartmentData
{
    public static int[] TestUsers = new[] { 35012, 34967 };
    public static string[] Departments = new[] { "2E97527D-5BD7-4CC0-81B8-14B6C2CA325F" };

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
            CountryId = EnumCountry.Finland,
            Level = 1,
            IsActive = true
        };
    }

    public static DepartmentInsertData[] CreateDepartmentDataList(int count) =>
        Enumerable.Range(0, count).Select(i => CreateDepartmentData(i.ToString())).ToArray();

    public static void UpdateDepartmentData(DepartmentInsertData departmentInsertData)
    {
        const string updated = "updated";
        departmentInsertData.CountryId = departmentInsertData.CountryId == EnumCountry.Finland ?
            EnumCountry.UnitedStatesOfAmerica : EnumCountry.Finland;
    }

    public static DepartmentUpdateData ToDepartmentUpdateData(this DepartmentInsertData departmentInsertData) =>
        new
        (
            name: departmentInsertData.Name,
            contactName: departmentInsertData.ContactName,
            contactEmail: departmentInsertData.ContactEmail,
            countryId: departmentInsertData.CountryId
        );

    public static DepartmentData ToDepartmentData(this DepartmentInsertData departmentInsertData) =>
        new
        (
            id: departmentInsertData.Id,
            name: departmentInsertData.Name,
            departmentTypeId: departmentInsertData.DepartmentTypeId,
            contactName: departmentInsertData.ContactName,
            contactEmail: departmentInsertData.ContactEmail,
            countryId: departmentInsertData.CountryId
        );
}
