using Agile.Now.AccessHub.Model;

namespace Agile.Now.AccessHub.Test.Data;

public class UserTestData
{
    public static readonly int[] Users = new[] { 35012, 34967, 16862 };

    public static UserData CreateUserData(int id) => new(userId: new("Id", id.ToString()));

    public static UserData1 CreateUserData1(int userId) => new(userId: new("Id", userId.ToString()));

    public static readonly int[] Groups = new[] { 6626, 6625, 6624 };

    public static GroupData CreateGroupData(int id) => new(groupId: new("Id", id.ToString()));
}
