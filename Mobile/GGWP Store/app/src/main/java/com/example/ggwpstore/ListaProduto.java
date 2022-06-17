package com.example.ggwpstore;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class ListaProduto extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lista_produto);
    }
    public void login(View v){
        Intent tela = new Intent(this,Login.class);
        startActivity(tela);
    }
    public void menu(View v){
        Intent tela = new Intent(this,MainActivity.class);
        startActivity(tela);
    }
    public void carinho(View v){
        Intent tela = new Intent(this,Carrinho.class);
        startActivity(tela);
    }
    public void funko(View v){
        Intent tela = new Intent(this,Produto.class);
        startActivity(tela);
    }
}