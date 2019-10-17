using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gamewebapi
{
    
public class PlayerList{
    public List<Player> allPlayers;
}
public class Player
{

    public Player()
    {
        Items = new List<Item>();
    }
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Range(1,999)]
    public int Score { get; set; }
    [Range(1,99)]
    public int Level { get; set; }
    public bool IsBanned { get; set; }
    public DateTime CreationTime { get; set; }
    public List<Item> Items { get; set; }
}}