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

  registerStudent(student:User):Observable<number>
  {
    return this.http.post<number>(environment.url+'user/RegisterStudent',student);
  }

  uploadStudentsDetailes(file: File):Observable<boolean> {
    let formData = new FormData();
     formData.append('file', file);
     return this.http.post<boolean>(environment.url+'user/uploadStudentsDetailes',formData);

  }
}
