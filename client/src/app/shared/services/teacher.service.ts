import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Class } from '../models/class.model';
import { User } from '../models/user.model';
import { Week } from '../models/week.model';
import { WordCategory } from '../models/wordCategory.model';

@Injectable({
  providedIn: 'root'
})
export class TeacherService {

  constructor(private http: HttpClient) { }


  getClassListForTeacher(teacherCode) 
  {
    return this.http.get<Class[]>(environment.url + 'teacher/getClassListForTeacher/'+teacherCode)

  }

  getStudentListForTeacher(teacherCode,classCode)
  {
    return this.http.get<User[]>(environment.url + 'teacher/getStudentListForTeacher/' + teacherCode+'/'+classCode)

  }
  getWeekListForClass(classCode)
  {
    return this.http.get<Week[]>(environment.url + 'teacher/getWeekListForClass/' + classCode)

  }

  getCategoryListForClass(classCode)
  {
    return this.http.get<WordCategory[]>(environment.url + 'teacher/getCategoryListForClass/'  + classCode)

  }
}
