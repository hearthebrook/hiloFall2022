class Score {

    int currentScore = 0;
    
    public Score(int defaultScore){
        currentScore = defaultScore;
    }

    public void addPoints(int points){
        currentScore += points;
    }
    public void takeAwayPoints(int points){
        currentScore -= points;
    }
    public bool isScoreZero(){
        if (currentScore <= 0){
            return true;
        }
        else{
            return false;
        }
    }
    public void distplayScore(){
        Console.WriteLine($"Your score is {currentScore}");
    }
}



/*
class score {
    int  = new List<int>();
    
    public score(){
        
    }
}
*/