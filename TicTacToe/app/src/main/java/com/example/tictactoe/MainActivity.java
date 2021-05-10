package com.example.tictactoe;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import java.util.Observable;
import java.util.Observer;
import android.widget.Button;


public class MainActivity extends AppCompatActivity implements Observer{

    public Button []_button = new Button[9];

    public MainActivity(Controller C){
        for(int i = 0; i<_button.length; i++) {
            _button[i]= new Button(this);
            _button[i].setOnClickListener(C);
            _button[i].setId(i);
        }
    }


    public void update(Observable o, Object arg){
        // Skapar variabler
        int[] gameboard = ((Model)o).getMarks();
        int winner = ((Model)o).getWinner();

        // Skriver ut tecken på knapp och inaktiverar den
        for(int i=0; i <_button.length;i++) {
            if (gameboard[i] == 1) {
                _button[i].setText("O");
                _button[i].setEnabled(false);
                //_button[i].setFont(new Font("Arial", Font.BOLD, 70));

            } else if(gameboard[i]== 2) {
                _button[i].setText("X");
                _button[i].setEnabled(false);
               // _button[i].setFont(new Font("Arial", Font.BOLD, 70));
            }
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }
}
