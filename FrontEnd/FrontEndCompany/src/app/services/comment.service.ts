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

  addComment(comment: Comment) {
    return this.http.post<Comment>(this._baseURL + "/AddComment", comment);
  }

  deleteComment(commentId: number) {
    return this.http.delete<Comment>(this._baseURL + "/DeleteComment/" + commentId);
  }
  updateComment(commentId: number, text: string)
  {
    return this.http.put<Comment>(this._baseURL+ "/UpdateComment/" + commentId, {text});
  }
}
