import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class WordCategoryService {

  constructor(private http:HttpClient) { }
  GetCategoryListForClass(classCode: number)
  {
    
    //params = params.append('teacherId', teacerCode);
   // params = params.append( 'classId',stringify( classCode));

    return this.http.get(environment.url + "teacher/GetCategoryListForClass/"+classCode);
  }

  GetWordsById(categoryNum: number)
  {
    
    //params = params.append('teacherId', teacerCode);
   // params = params.append( 'classId',stringify( classCode));

    return this.http.get(environment.url + "word/GetWordsById/"+categoryNum);
  }
}

