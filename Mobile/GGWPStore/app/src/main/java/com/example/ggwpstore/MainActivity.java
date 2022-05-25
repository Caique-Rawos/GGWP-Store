package com.example.ggwpstore;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void funkopop(View v){
        Intent tela = new Intent(this,FunkoPopActivity.class);
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
    public void produtos(View v){
        Intent tela = new Intent(this,ProdutosActivity.class);
        startActivity(tela);
    }
}