
Deck cardDeck = new Deck();
Score scoreCard = new Score(300);

bool game = true;

int first_card = cardDeck.drawRandom();

while (game == true) {
    Console.WriteLine($"The card is {first_card} ");
    Console.Write("Higher or Lower? [h/l] ");
    string? guess = Console.ReadLine();

    int second_card = cardDeck.drawRandom();
    Console.WriteLine($"Next card was {second_card}");

    if (second_card > first_card && guess == "h"){
        Console.WriteLine("That is correct!");
        scoreCard.addPoints(100);
        scoreCard.distplayScore();
    }
    else if (second_card < first_card && guess == "l"){
        Console.WriteLine("That is correct!");
        scoreCard.addPoints(100);
        scoreCard.distplayScore();
    }
    else if (second_card == first_card){
        Console.WriteLine("It's a tie! No points added or taken away :)");
        scoreCard.distplayScore();
    }
    else{
        Console.WriteLine("Wrong!");
        scoreCard.takeAwayPoints(75);
        scoreCard.distplayScore();
    }

    game = !(scoreCard.isScoreZero());

    Console.Write("Play again? [y/n] ");
    string? keepGoing = Console.ReadLine();
    if (keepGoing == "n"){
        game = false;
    }

    Console.WriteLine("");
    cardDeck.removeCard(first_card);
    first_card = second_card;
}


Console.WriteLine("Thanks for playing");