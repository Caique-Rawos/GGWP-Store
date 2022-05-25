package com.example.ggwpstore;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class PerfilActivity2 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_perfil2);
    }

    public void perfil(View v){
        Intent tela = new Intent(this,PerfilActivity.class);
        startActivity(tela);
    }
    public void funkopop(View v){
        Intent tela = new Intent(this,FunkoPopActivity.class);
        startActivity(tela);
    }

}