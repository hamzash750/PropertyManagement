import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthorizationService {

  mainUrl=environment.url_EndPoint;
  constructor(private http: HttpClient) { }
  LoginUser(data:any): Observable<any> {
    return this.http.post(this.mainUrl+'Authorization/Login',data);
  }
  RegisterUser(data:any): Observable<any> {
    return this.http.post(this.mainUrl+'Authorization/Register',data);
  }
}
