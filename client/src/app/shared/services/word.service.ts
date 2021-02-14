import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { Word } from '../models/word.model';

@Injectable({
  providedIn: 'root'
})
export class WordService {

  constructor(private http:HttpClient) { }

  
}
