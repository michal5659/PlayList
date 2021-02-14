import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../models/user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  

  constructor(private http:HttpClient) { }

  login(user: User) : Observable<User>
  {
    return this.http.post<User>(environment.url+'user/Login',user);
  }

  registerTeacher(teacher:User):Observable<number>
  {
    return this.http.post<number>(environment.url+'user/RegisterTeacher',teacher);
  }

  registerStudent(student:User):Observable<number>
  {
    return this.http.post<number>(environment.url+'user/RegisterStudent',student);
  }

  getStudentByClass(listClass: string[])
  {
    let params = new HttpParams();
    params = params.append('listClass', listClass.join(', '));
    return this.http.get(environment.url + "GetListOfUsersById",{ params: params });
  }

  uploadStudentsDetailes(file: File):Observable<boolean> {
    let formData = new FormData();
     formData.append('file', file);
     return this.http.post<boolean>(environment.url+'user/uploadStudentsDetailes',formData);

  }
}
