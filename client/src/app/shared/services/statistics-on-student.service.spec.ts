import { TestBed } from '@angular/core/testing';

import { StatisticsOnStudentService } from './statistics-on-student.service';

describe('StatisticsOnStudentService', () => {
  let service: StatisticsOnStudentService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StatisticsOnStudentService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
