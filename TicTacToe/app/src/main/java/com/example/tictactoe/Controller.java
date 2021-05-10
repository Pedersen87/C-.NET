package com.example.tictactoe;


import android.view.View;
import android.widget.Button;

public class Controller implements View.OnClickListener {
    // Skapar variabler
    private Model M;
    public Controller (Model M) {

    }

    @Override
    public void onClick(View v) {
        Button temp = (Button)v;
        M.putMarks(temp.getId());
    }
}
