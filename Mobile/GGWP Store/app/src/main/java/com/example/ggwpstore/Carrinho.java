package com.example.ggwpstore;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class Carrinho extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_carrinho);
    }
    public void login(View v){
        Intent tela = new Intent(this,Login.class);
        startActivity(tela);
    }
    public void menu(View v){
        Intent tela = new Intent(this,MainActivity.class);
        startActivity(tela);
    }
}