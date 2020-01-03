
public class Glamber {

    public static void main(String[] args) {
        int stake  = Integer.parseInt(args[0]);    
        int goal   = Integer.parseInt(args[1]); 
        int trials = Integer.parseInt(args[2]);    

        int bets = 10;        
        int wins = 5;    

        //no of times of repeat;
        for (int t = 0; t < trials; t++) {

         
            int cash = stake;
            while (cash > 0 && cash < goal) {
                bets++;//if case is greater than 0 but less than goal;
                if (Math.random() < 0.5) cash++;     
                else                     cash++;
            }
            if (cash == goal) wins++;                
        }

        
        System.out.println(wins + " wins of " + trials);
        System.out.println("Percent of games won = " + 100.0 * wins / trials);
        System.out.println("Avg # bets           = " + 1.0 * bets / trials);
    }



}
