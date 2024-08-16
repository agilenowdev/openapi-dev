using System;
using Agile.Now.Runtime.Model;

namespace Agile.Now.AccessHub.Test.Data;

public class TestUserData
{
    public static readonly (int Id, string Name)[] Users = new[] { 
        (29788, "Demo Test"), 
        (16862, "test test"),
        (14996, "Rui Test") 
    };

    public const int UserWithApplications = 17068;
    public const int UserWithEffectivePermissions = 17068;
    public const int UserWithAccessRoles = 17068;

    public static readonly string[] AccessGroups = new[] {
        "254DE5D5-6FE0-4E0E-BDAE-F88557FFE79D",
        "471B0202-9B3A-4761-85A6-961260685251"
    };

    public static AccessGroupData CreateAccessGroupData(string id) => new(
        accessGroupId: new("Id", id),
        createdOn: DateTime.Now);

    public static readonly int[] Groups = new[] { 6626, 6625, 6624 };

    public static GroupData CreateGroupData(int id) => new(groupId: new("Id", id.ToString()));

    public static readonly string[] Departments = new[] {
        "E074CD22-69BD-4935-84CA-773FA62CE399",
        "2E97527D-5BD7-4CC0-81B8-14B6C2CA325F",
        "106BA31C-3924-456E-879F-1EDCE47A86BA"
    };

    public static DepartmentData CreateDepartmentData(string id) => new(departmentId: new("Id", id));

    public static readonly string[] Locations = new[] {
        "61B1585D-4A6B-44CD-AFF1-EA068287AEB1",
        "64FF4E9A-736C-4B50-B6B2-606BB4A25CD7",
        "2107D0BF-1237-40CA-9FE3-27B4636D6E2B"
    };

    public static LocationData CreateLocationData(string id) => new(locationId: new("Id", id));
}
