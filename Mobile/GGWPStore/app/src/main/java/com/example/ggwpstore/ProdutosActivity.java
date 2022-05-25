package com.example.ggwpstore;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class ProdutosActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_produtos);
    }

    public void menu(View v){
        Intent tela = new Intent(this,MainActivity.class);
        startActivity(tela);
    }

    public void login(View v){
        Intent tela = new Intent(this,LoginActivity.class);
        startActivity(tela);
    }
    public void carinho(View v){
        Intent tela = new Intent(this,CarrinhoActivity.class);
        startActivity(tela);
    }
    public void fumkopop(View v){
        Intent tela = new Intent(this,FunkoPopActivity.class);
        startActivity(tela);
    }
}