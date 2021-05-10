package com.example.tictactoe;

import java.util.Observable;

public class Model extends Observable {
    // Skapar variabel namn
    private int buttonArr[];
    int counter = 0;
    int winner = 0;

    public Model() {
        buttonArr = new int [9];
    }

    public int getWinner() {
        return winner;
    }

    public void setWinner(int j) {
        winner = j;
    }

    public int [] getMarks() {
        return buttonArr;
    }

    // Kontrollerar vilket tecken som ska skrivas ut och om någon vunnit
    public void putMarks (int i) {
        if (counter % 2 ==1) {
            buttonArr[i]= 1;
        } else {
            buttonArr[i] = 2;
        }
        counter++;

        //Vinstkombinationer
        if(buttonArr[0]== 1 && buttonArr[1]==1 && buttonArr[2]==1) {
            winner = 1;
        }
        if(buttonArr[3]==1 && buttonArr[4]==1 && buttonArr[5]==1) {
            winner = 1;
        }
        if(buttonArr[6]==1&& buttonArr[7]==1&& buttonArr[8]==1) {
            winner = 1;
        }

        // Vinster på vågrätt (O)
        if(buttonArr[0]==1 && buttonArr[4]==1 && buttonArr[8]== 1) {
            winner = 1;
        }
        if(buttonArr[2]== 1 && buttonArr[4]== 1 && buttonArr[6]==1) {
            winner = 1;
        }

        // Vinst på diagonal (O)
        if(buttonArr[0]==1 && buttonArr[3]==1 && buttonArr[6]==1) {
            winner = 1;
        }
        if(buttonArr[1]==1 && buttonArr[4]==1 && buttonArr[7]==1) {
            winner = 1;
        }
        if(buttonArr[2]==1 && buttonArr[5]==1 && buttonArr[8]==1) {
            winner = 1;
        }

        // Vinst på lodrätta (O)
        if(buttonArr[0]== 2 && buttonArr[1]==2 && buttonArr[2]==2) {
            winner = 2;
        }
        if(buttonArr[3]==2 && buttonArr[4]==2 && buttonArr[5]==2) {
            winner =2;
        }
        if(buttonArr[6]==2&& buttonArr[7]==2&& buttonArr[8]==2) {
            winner = 2;
        }

        // Vinster på vågrätt (X)
        if(buttonArr[0]==2 && buttonArr[4]==2 && buttonArr[8]== 2) {
            winner = 2;
        }
        if(buttonArr[2]== 2 && buttonArr[4]== 2 && buttonArr[6]==2) {
            winner = 2;
        }

        // Vinst på diagonal (X)
        if(buttonArr[0]==2 && buttonArr[3]==2&& buttonArr[6]==2) {
            winner = 2;
        }
        if(buttonArr[1]==2 && buttonArr[4]==2&& buttonArr[7]==2) {
            winner = 2;
        }
        if(buttonArr[2]==2 && buttonArr[5]==2&& buttonArr[8]==2) {
            winner = 2;
        }

        // Vinst på lodrätta (X)
        if (counter == 9 && winner == 0) {
            setWinner(3);
            counter = 0;
        }
        setChanged();
        notifyObservers();
    }
    // Återställer buttonArr
    public void reset() {
        winner  = 0;
        counter = 0;
        for(int i=0; i<buttonArr.length; i++) {
            buttonArr[i]=0;
        }
    }


}
