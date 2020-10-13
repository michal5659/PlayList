import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../models/user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpClient) { }

  registerTeacher(teacher:User):Observable<number>
  {
    return this.http.post<number>(environment.url+'user/RegisterTeacher',teacher);
  }
}
