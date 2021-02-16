import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { DiagramData } from '../models/diagramData.model';

@Injectable({
  providedIn: 'root'
})
export class StatisticsOnStudentService {

  constructor(private http:HttpClient) { }

  schoolStatistics(teacherCode,classCode,weekNum): Observable<DiagramData>
  {
    return this.http.get<DiagramData>(environment.url+`statistics/classWeek/${classCode}/${teacherCode}/${weekNum}`)
  }

  classStatistics(classCode)
  {
    return this.http.get<DiagramData[]>(environment.url + `statistics/class1/${classCode}`)

  }

  studentStatistics(studentCode)
  {
    return this.http.get<DiagramData[]>(environment.url + `statistics/student/${studentCode}`)

  }

}
