using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogCSharp.Models;

public class Post
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int Id { get; set; }
    public string Name { get; set; }
    public BlogUser UserId { get; set; }
    public string Title { get; set;}
    public string Content { get; set; }
    public DateTime DateOfCreation { get; set; } = DateTime.UtcNow;

}
