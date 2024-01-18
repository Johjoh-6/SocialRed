using System.ComponentModel.DataAnnotations.Schema;

namespace SocialRed.Models;

[Table("users")]
public class Users
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("email")]
    public string Email { get; set; }
    [Column("friends")]
    public List<Users> Friends { get; set; }
    [Column("followers")]
    public List<Users> Followers { get; set; }
    [Column("following")]
    public List<Users> Following { get; set; }
    // public List<Posts> Posts { get; set; }
    // public List<Comments> Comments { get; set; }

    public Users(string name, string email)
    {
        Name = name;
        Email = email;
        Friends = new List<Users>();
        Followers = new List<Users>();
        Following = new List<Users>();
        // Posts = new List<Posts>();
        // Comments = new List<Comments>();
    }

    public void AddFriend(Users user)
    {
        Friends.Add(user);
    }

    public void AddFollower(Users user)
    {
        Followers.Add(user);
    }

    public void AddFollowing(Users user)
    {
        Following.Add(user);
    }

    // public void AddPost(Posts post) {
    //     Posts.Add(post);
    // }

    // public void AddComment(Comments comment) {
    //     Comments.Add(comment);
    // }

    public void RemoveFriend(Users user)
    {
        Friends.Remove(user);
    }

    public void RemoveFollower(Users user)
    {
        Followers.Remove(user);
    }

    public void RemoveFollowing(Users user)
    {
        Following.Remove(user);
    }

    // public void RemovePost(Posts post) {
    //     Posts.Remove(post);
    // }

    // public void RemoveComment(Comments comment) {
    //     Comments.Remove(comment);
    // }

    public void ShowProfile()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Friends: {Friends.Count}");
        ShowFriends();
        Console.WriteLine($"Followers: {Followers.Count}");
        ShowFollowers();
        Console.WriteLine($"Following: {Following.Count}");
        ShowFollowing();
        // TODO add posts and comments
    }

    public void ShowFriends()
    {
        foreach (var friend in Friends)
        {
            Console.WriteLine($"Name: {friend.Name}");
            Console.WriteLine($"Email: {friend.Email}");
        }
    }

    public void ShowFollowers()
    {
        foreach (var follower in Followers)
        {
            Console.WriteLine($"Name: {follower.Name}");
            Console.WriteLine($"Email: {follower.Email}");
        }
    }

    public void ShowFollowing()
    {
        foreach (var following in Following)
        {
            Console.WriteLine($"Name: {following.Name}");
            Console.WriteLine($"Email: {following.Email}");
        }
    }

}
