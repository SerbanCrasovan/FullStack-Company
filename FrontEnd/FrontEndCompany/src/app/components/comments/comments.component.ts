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

  @Input() companyId: number | undefined;
  
  constructor(private service: CommentService) {}
  
  ngOnChanges(): void {
    this.service.getAllComments(this.companyId!).subscribe(data => {
      this.comments = data;
    })
  }
  
}
