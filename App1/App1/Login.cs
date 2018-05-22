using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    [Activity(Label = "Login")]
    public class Login : Activity
    {
        private Button mBtnSignUp;
        private Button mBtnSignIn;
        private Button mBtnGast;


        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            
            SetContentView(Resource.Layout.Login);


            mBtnSignIn = FindViewById<Button>(Resource.Id.btnSignin);

            mBtnSignIn.Click += (object sender, EventArgs args) =>
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_SignIn signInDialog = new dialog_SignIn();
                signInDialog.Show(transaction, "dialog fragment2");
            };

            mBtnSignUp = FindViewById<Button>(Resource.Id.btnSignup);

            mBtnSignUp.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_SignUp signUpDialog = new dialog_SignUp();
                signUpDialog.Show(transaction, "dialog fragment");
            };

            mBtnGast = FindViewById<Button>(Resource.Id.button1);

            mBtnGast.Click += (object sender, EventArgs args) =>
            {
                var intent = new Intent(this, typeof(Profiel));
                StartActivity(intent);
            };
        }
    
    }
}