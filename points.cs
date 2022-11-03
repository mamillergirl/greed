void UserTurn(string userChoice){
        //string userChoice = GetChoice();
        var newCard = deck.shuffleCard();
        if (userChoice == "l" && newCard < PreviousCard){
            Points += 100;
        }
        else if (userChoice == "h" && newCard > PreviousCard){
            Points += 100; 
        }

        if (userChoice == "l" && newCard > PreviousCard){
            Points -= 75;
        }
        else if (userChoice == "h" && newCard < PreviousCard){
            Points -= 75; 
        }
        PreviousCard = newCard;
    }

     if (Raylib.CheckCollisionRecs(PlayerRectangle, TargetRectangle)) {
                    Raylib.DrawText("You did it!!!!", 12, 34, 20, Color.BLACK);
                }
