package com.example.ggwpstore;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class Perfil2 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_perfil2);
    }
    public void menu(View v){
        Intent tela = new Intent(this,MainActivity.class);
        startActivity(tela);
    }
    public void carinho(View v){
        Intent tela = new Intent(this,Carrinho.class);
        startActivity(tela);
    }
}