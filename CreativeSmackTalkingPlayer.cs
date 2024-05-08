namespace ShootingDice;
// A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
public class CreativeSmackTalkingPlayer  : Player
{
    private List<string> Taunts = new List<string>
    {
        "Die, Tiger!", "Aloha, Satan!", "Yo mama so fat that she whipped out a pistol to brush a crumb of tartar sauce off of your scrumdeliocious face. SAD!"    
    };
    private Random random = new Random();
    public override void Play(Player other)
    {
        // Call roll for "this" object and for the "other" object
        int myRoll = Roll();
        int otherRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");
        if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < otherRoll)
        {
            Console.WriteLine($"{other.Name} Wins!");
            int randomIndex = random.Next(Taunts.Count);
            Console.WriteLine(Taunts[randomIndex]);
        }
        else
        {
            // if the rolls are equal it's a tie
            Console.WriteLine("It's a tie");
        }
    }

}
