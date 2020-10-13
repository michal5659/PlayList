import { TestBed } from '@angular/core/testing';

import { StudentsFeedbackService } from './students-feedback.service';

describe('StudentsFeedbackService', () => {
  let service: StudentsFeedbackService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StudentsFeedbackService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
