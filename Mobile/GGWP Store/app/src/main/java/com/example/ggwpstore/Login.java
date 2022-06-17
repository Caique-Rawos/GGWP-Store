package com.example.ggwpstore;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class Login extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
    }
    public void menu(View v){
        Intent tela = new Intent(this,MainActivity.class);
        startActivity(tela);
    }
    public void carinho(View v){
        Intent tela = new Intent(this,Carrinho.class);
        startActivity(tela);
    }
    public void esqueceuSenha(View v){
        Intent tela = new Intent(this,RecuperarSenha.class);
        startActivity(tela);
    }
    public void cadastro(View v){
        Intent tela = new Intent(this,registro.class);
        startActivity(tela);
    }
    public void perfil(View v){
        Intent tela = new Intent(this,Perfil2.class);
        startActivity(tela);
    }
}