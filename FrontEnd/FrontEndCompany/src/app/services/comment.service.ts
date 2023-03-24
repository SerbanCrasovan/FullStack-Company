import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Comment } from 'src/app/interfaces/comment'

@Injectable({
  providedIn: 'root'
})
export class CommentService {

  _baseURL: string = "api/Comments";

  constructor(private http: HttpClient) { }

  getAllComments(id: number) {
    return this.http.get<Comment[]>(this._baseURL+"/" + id);
  }
}
