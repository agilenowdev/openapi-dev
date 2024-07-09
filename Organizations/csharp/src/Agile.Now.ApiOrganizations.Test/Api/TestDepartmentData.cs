using System;
using System.Linq;
using Agile.Now.ApiOrganizations.Model;

namespace Agile.Now.ApiOrganizations.Test.Api
{
    internal static class TestDepartmentData
    {
        public static DepartmentInsertData CreateDepartmentData(string suffix = null)
        {
            var name = "unit-test-department" + suffix;
            var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
            return new
            (
                name: uniqueName,
                departmentTypeId: new("Id", "Internal"),
                parentDepartmentId: new("Id", null),
                contactName: name,
                contactEmail: name + "@agilenow.io"
            )
            {
                CountryId = new("Name", "Finland"),

            };
        }

        public static DepartmentInsertData[] CreateDepartmentDataList(int count) =>
            Enumerable.Range(0, count).Select(i => CreateDepartmentData(i.ToString())).ToArray();

        public static DepartmentUpsertData ToDepartmentUpsertData(this DepartmentInsertData departmentInsertData) =>
            new
            (
                name: departmentInsertData.Name,
                departmentTypeId: departmentInsertData.DepartmentTypeId,
                parentDepartmentId: departmentInsertData.ParentDepartmentId,
                contactName: departmentInsertData.ContactName,
                contactEmail: departmentInsertData.ContactEmail,
                countryId: departmentInsertData.CountryId
            );

        public static DepartmentUpdateData UpdateDepartmentData(DepartmentInsertData departmentInsertData, string id = null)
        {
            if (id != null)
                departmentInsertData.Id = id;
            const string updated = "updated";
            return new
            (
                name: departmentInsertData.Name,
                contactName: departmentInsertData.ContactName = departmentInsertData.ContactName += updated,
                contactEmail: departmentInsertData.ContactEmail = updated + departmentInsertData.ContactEmail
            );
        }
    }
}
