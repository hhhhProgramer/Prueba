SELECT Reviewer.name,Book.title,Rating.rating,Rating.rating_date  FROM ratings AS Rating
INNER JOIN reviewers AS Reviewer on Reviewer.id  = Rating.reviewer_id 
INNER JOIN books AS Book ON Book.id = Rating.book_id
ORDER BY Reviewer.name,Book.title,Rating.rating; 