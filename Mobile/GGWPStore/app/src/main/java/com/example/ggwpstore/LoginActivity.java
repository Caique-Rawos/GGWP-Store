package com.example.ggwpstore;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class LoginActivity extends AppCompatActivity {

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
        Intent tela = new Intent(this,CarrinhoActivity.class);
        startActivity(tela);
    }
    public void perfil(View v){
        Intent tela = new Intent(this,PerfilActivity.class);
        startActivity(tela);
    }
    public void registro(View v){
        Intent tela = new Intent(this,RegistroActivity.class);
        startActivity(tela);
    }
    public void recSenha(View v){
        Intent tela = new Intent(this,RecuperarSenhaActivity.class);
        startActivity(tela);
    }
}