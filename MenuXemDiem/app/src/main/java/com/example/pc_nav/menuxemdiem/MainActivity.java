package com.example.pc_nav.menuxemdiem;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    ImageView imgHinh;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        imgHinh=(ImageView)findViewById(R.id.imgHinh);
        imgHinh.setImageResource(R.drawable.logohufipng);
    }
}
