package com.example.ggwpstore;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class PerfilActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_perfil);
    }
    public void menu(View v){
        Intent tela = new Intent(this,MainActivity.class);
        startActivity(tela);
    }

    public void perfil2(View v){
        Intent tela = new Intent(this,PerfilActivity2.class);
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

}