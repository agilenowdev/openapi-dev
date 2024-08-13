using Agile.Now.AccessHub.Model;
using System;

namespace Agile.Now.AccessHub.Test.Data;

public class UserTestData
{
    public static int[] Users = new[] { 35012, 34967, 16862 };

    public static UserData CreateUserData(int id) => new(
        userId: new("Id", id.ToString()),
        createdOn: DateTime.Now);

    public static UserData1 CreateUserData1(int id) => new(userId: new("Id", id.ToString()));

    public static int[] Groups = new[] { 6626, 6625, 6624 };
}
