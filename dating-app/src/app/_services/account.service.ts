import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { BehaviorSubject, map, Observable, tap } from 'rxjs';
import { AuthUser, UserToken } from '../_models/app-user';
import { __values } from 'tslib';
@Injectable({
  providedIn: 'root'
})
export class AccountService {
  httpOptions = {
    headers : new HttpHeaders({
      'Content-Type' : 'application/json'
    })
  }
  baseUrl = "https://localhost:7232/api/auth";
  private currentUser = new BehaviorSubject<any>(null);
  currentUser$ = this.currentUser.asObservable();
  constructor(private httpCleint : HttpClient) { }

  login(authUser : AuthUser): Observable<any>{
    return this.httpCleint.post<UserToken>(`${this.baseUrl}/login`,authUser,this.httpOptions)
    .pipe(
      map((response : UserToken) =>{
        if(response){
          localStorage.setItem("token",JSON.stringify(response.token))
          this.currentUser.next(response);
        }
      })
    )
  }

  logout(){
    this.currentUser.next(null);
    localStorage.removeItem("token")
  }
  
  register(){

  }
}
