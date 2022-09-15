import { Component, OnDestroy, OnInit, AfterViewInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthorizationService } from '../services/authorization.service';
const url = 'assets/js/mymain.js';
declare var $:any;
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit,AfterViewInit ,OnDestroy {
  constructor(private formBuilder: FormBuilder,private _AuthorizationService:AuthorizationService) { }

  registerForm = this.formBuilder.group({

    email: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(6)]]}
);
 
  ngOnInit(): void {
  }
  ngAfterViewInit(): void {
    //Called after ngAfterContentInit when the component's view has been initialized. Applies to components only.
    //Add 'implements AfterViewInit' to the class.
setTimeout(() => {
  this.loadScript();
}, 500);
  }
  userLogin():void{
    console.log(this.registerForm.value)
    this._AuthorizationService.LoginUser(this.registerForm.value).subscribe(res=>{
      console.log(res)
    })
  }
  public loadScript() {
    let node = document.createElement('script');
    node.src = url;
    node.id="mainScript";
    node.type = 'text/javascript';
    node.async = true;
    node.charset = 'utf-8';
    document.getElementsByTagName('head')[0].appendChild(node);
  }
  ngOnDestroy(): void {
    $('#mainScript').remove();
  }
}