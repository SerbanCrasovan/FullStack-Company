import { Component, OnChanges, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Comment } from 'src/app/interfaces/comment';
import { CommentService } from 'src/app/services/comment.service';

@Component({
  selector: 'app-comments',
  templateUrl: './comments.component.html',
  styleUrls: ['./comments.component.css']
})
export class CommentsComponent implements OnChanges{
  
  public comments: Comment[] = [];

  public newCommentText : string = '';

  @Input() companyId: number = 0;
  
  constructor(private service: CommentService) {}
  
  ngOnChanges(): void {
    this.service.getAllComments(this.companyId!).subscribe(data => {
      this.comments = data;
    })
  }

  public onSubmit() {
    if(!this.newCommentText) {
      return;
    }

    const newComment: Comment = {
      id : 0,
      companyId : this.companyId,
      text : this.newCommentText
    };

    this.service.addComment(newComment).subscribe(() => {
      this.comments.push(newComment);
      this.newCommentText = '';
    })
  }
    
  public deleteComment(commentId: number): void {
    this.service.deleteComment(commentId).subscribe(() => {
      this.comments = this.comments.filter((comment) => comment.id !== commentId);
    });
  }

  public updateComment(commentId: number ) {
    this.service.updateComment(commentId, this.newCommentText).subscribe(updatedComment => {
      const index = this.comments.findIndex(c => c.id === updatedComment.id);
      this.comments[index] = updatedComment;
    })
  }
  
}
