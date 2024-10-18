using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class Department_TestData : TestData<Department, DepartmentInsertData> {
    public override void AssertEqualToRequest(DepartmentInsertData expected, Department actual) {
        Assert.Equal(expected.ExternalId, actual.ExternalId);
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.DepartmentTypeId, EnumDepartmentTypeValueConverter.FromString(actual.DepartmentTypeId.Id));
        Assert.Equal(expected.ParentDepartmentId.Value ?? "", actual.ParentDepartmentId.Id ?? "");
        Assert.Equal(expected.ContactName, actual.ContactName);
        Assert.Equal(expected.ContactEmail, actual.ContactEmail);
        Assert.Equal(expected.CountryId, EnumCountryValueConverter.FromString(actual.CountryId.Id));
    }

    public override void AssertEqualToResponse(Department expected, Department actual) {
        Assert.Equal(expected.Id, actual.Id);
        //Assert.Equal(expected.ExternalId, actual.ExternalId);
        //Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.DepartmentTypeId.Id, actual.DepartmentTypeId.Id);
        Assert.Equal(expected.ParentDepartmentId.Id ?? "", actual.ParentDepartmentId.Id ?? "");
        Assert.Equal(expected.ContactName, actual.ContactName);
        Assert.Equal(expected.ContactEmail, actual.ContactEmail);
        Assert.Equal(expected.CountryId.Id, actual.CountryId.Id);
    }

    public override void Update(DepartmentInsertData data) {
        data.ContactName = data.ContactName.MarkUpdated();
        data.ContactEmail = data.ContactEmail.MarkUpdated();
        data.CountryId = data.CountryId ==
            EnumCountry.Finland ? EnumCountry.UnitedStatesOfAmerica : EnumCountry.Finland;
    }

    public override IEnumerable<DepartmentInsertData> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => {
            var name = CreateTestEntityName("department", i.ToString());
            return new DepartmentInsertData(
                externalId: Guid.NewGuid().ToString(),
                name: name.MakeUnique(),
                departmentTypeId: EnumDepartmentType.Internal,
                parentDepartmentId: new("Id", ""),
                contactEmail: name + "@agilenow.io",
                contactName: name,
                countryId: EnumCountry.Finland
            );
        });
}

public static class DepartmentTestData_Extention {
    public static DepartmentUpdateData ToDepartmentUpdateData(this DepartmentInsertData departmentInsertData) => new(
        externalId: departmentInsertData.ExternalId,
        name: departmentInsertData.Name,
        contactName: departmentInsertData.ContactName,
        contactEmail: departmentInsertData.ContactEmail,
        countryId: departmentInsertData.CountryId
    );

    public static DepartmentData ToDepartmentData(this DepartmentInsertData departmentInsertData) => new(
        externalId: departmentInsertData.ExternalId,
        name: departmentInsertData.Name,
        parentDepartmentId: departmentInsertData.ParentDepartmentId,
        departmentTypeId: departmentInsertData.DepartmentTypeId,
        contactName: departmentInsertData.ContactName,
        contactEmail: departmentInsertData.ContactEmail,
        countryId: departmentInsertData.CountryId
    );
}
