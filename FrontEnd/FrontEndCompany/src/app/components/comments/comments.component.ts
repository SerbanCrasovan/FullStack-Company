import { Component, OnChanges, Input } from '@angular/core';
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

  public editCommentText : string = '';

  public isEditing : boolean = false;

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
      isEditing: false,
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

  public onDelete(comment : Comment) {
    comment.isEditing = false;
  }

  public updateComment(commentId: number ) {
    this.service.updateComment(commentId, this.editCommentText).subscribe(() => {
      const comment = this.comments.find(c => c.id === commentId)!;
      comment.text = this.editCommentText;
      this.editCommentText = '';
      comment.isEditing = false;
    })
  }

  public onUpdate(comment: Comment) {
    this.editCommentText = comment.text;
    comment.isEditing = true;
  }

}
