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
    public void login(View v){
        Intent tela = new Intent(this,Login.class);
        startActivity(tela);
    }
    public void carinho(View v){
        Intent tela = new Intent(this,Carrinho.class);
        startActivity(tela);
    }
    public void lista(View v){
        Intent tela = new Intent(this,ListaProduto.class);
        startActivity(tela);
    }

    public void funko(View v){
        Intent tela = new Intent(this,Produto.class);
        startActivity(tela);
    }
}