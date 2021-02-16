import { HttpClient, HttpParams } from '@angular/common/http';
import { stringify } from '@angular/compiler/src/util';
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

  getStudentByTeacher(teacerCode: number, classCode: number)
  {
    let params = new HttpParams();
    //params = params.append('teacherId', teacerCode);
    params = params.append( 'classId',stringify( classCode));

    return this.http.get(environment.url + "teacher/GetStudentListForTeacher/"+teacerCode+"/"+classCode);
  }

  GetClassListForTeacher(teacerCode: number)
  {
    let params = new HttpParams();
    //params = params.append('teacherId', teacerCode);
   // params = params.append( 'classId',stringify( classCode));

    return this.http.get(environment.url + "teacher/GetClassListForTeacher/"+teacerCode);
  }

  GetUserById(userCode: number)
  {
    return this.http.get(environment.url + "user/GetUserById/"+userCode);
  }
}
